using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace Menu
{
    public partial class menuForm : Form
    {
        private String connectionString = "Data Source=(localdb)\\localThienPhu;Initial Catalog=MENU;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private DataTable? dt = null;
        public menuForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void loadLV(DataTable dt)
        {
            menuLV.Clear();


            menuLV.View = View.Details;
            //menuLV.LabelEdit = true;
            //menuLV.CheckBoxes = true;
            //menuLV.FullRowSelect = true;
            //menuLV.GridLines = true;
            //menuLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            // Duyet tung hang

            foreach (DataColumn column in dt.Columns)
            {
                menuLV.Columns.Add(new ColumnHeader() { Text = column.ColumnName });
            }

            foreach (DataRow rows in dt.Rows)
            {
                //Lay gia tri cua cac cot trong hang
                ListViewItem? row = null;
                for (int i = 0; i < rows.Table.Columns.Count; i++)
                {
                    string? value = rows[i]?.ToString();
                    if (row == null)
                    {
                        row = new ListViewItem(value);
                    }
                    else
                    {
                        row.SubItems.Add(value);
                    }
                }
                if (row != null)
                {
                    menuLV.Items.Add(row);
                }
            }
            menuLV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private List<String> loadCBX()
        {
            List<String> cbx = new List<String>();
            if (dt != null && dt.Rows != null)
            {

                foreach (DataRow row in dt.Rows)
                {
                    cbx.Add(row["name"]?.ToString() ?? "");
                }

            }
            return cbx;
        }

        private void loadAll()
        {
            dt = LoadMenu();
            menudGV.DataSource = dt;
            loadLV(dt);
            menucBx.DataSource = loadCBX();
        }

        #endregion

        #region SQL Server

        private DataTable LoadMenu()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("selectAll", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }

        private void InsertMenu(String food, Double price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertFood", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", food);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@watch", DateTime.Now);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Insert Success");
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
                connection.Close();
            }
        }

        private void updateMenu(int id, string food, Double price, DateTime watch)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("updateFood", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", food);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@watch", watch);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Update Success");
                    }
                    else
                    {
                        MessageBox.Show("Update Fail");
                    }
                }
            }
        }

        #endregion

        #region Tool Windows
        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void foodTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String food = foodTxt.Text;
                Double price;

                if (!Double.TryParse(priceTxb.Text, out price))
                {
                    MessageBox.Show("Price is not valid");
                    return;
                }

                foodTxt.Clear();
                priceTxb.Clear();
                InsertMenu(food, price);
                loadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void menuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void priceTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "Ket qua ban da chon: ";
                foreach (ListViewItem item in menuLV.SelectedItems)
                {
                    str += $"{item.SubItems[1].Text}, ";
                }
                MessageBox.Show(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void menuLV_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt == null)
                    dt = LoadMenu();
                menudGV.DataSource = dt;
                loadLV(dt);
                menucBx.DataSource = loadCBX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void menudGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int id;
                string food;
                Double price;
                int.TryParse(menudGV.Rows[e.RowIndex].Cells["id"].Value?.ToString(), out id);
                Double.TryParse(menudGV.Rows[e.RowIndex].Cells["price"].Value?.ToString(), out price);
                food = menudGV.Rows[e.RowIndex].Cells["name"].Value?.ToString() ?? "";
                updateMenu(id, food, price, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void menudGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == menudGV.Columns["name"]?.Index ||
                    e.ColumnIndex == menudGV.Columns["price"]?.Index)
                {
                    Double price;
                    if (!Double.TryParse(menudGV.Rows[e.RowIndex].Cells["price"].Value?.ToString(),out price))
                    {
                        MessageBox.Show("Gia tri ban dua vao khong dung", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
    #endregion
}

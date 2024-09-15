using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireStationDeLavage
{
    public partial class Employer : Form
    {

        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Gestionnaire de lavage auto";
        public Employer()
        {
            InitializeComponent();
            loadEmployer();
        }

        private void dgvEmployer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

                EmployerModule module = new EmployerModule(this);
                byte[] imgData = dgvEmployer.Rows[e.RowIndex].Cells[2].Value as byte[];
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    Image image = Image.FromStream(ms);
                    module.pbPicturePreview.Image = image;
                };
                module.Eid.Text = dgvEmployer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dgvEmployer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtPhone.Text = dgvEmployer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtAddress.Text = dgvEmployer.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.dtDob.Text = dgvEmployer.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.rdMale.Checked = dgvEmployer.Rows[e.RowIndex].Cells[7].Value.ToString() == "Homme" ? true : false;
                module.cbRole.Text = dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.txtSalary.Text = dgvEmployer.Rows[e.RowIndex].Cells[9].Value.ToString();

                module.btnSave.Enabled = false;
                module.ShowDialog();
            } else if (colName == "Delete") { 
                try
                {
                    if (MessageBox.Show("Etes vous sûr de vouloir supprimer cet employé?", "Suppression employé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM tbEmployer WHERE id LIKE'" + dgvEmployer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("L'employé a bien été supprimé!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        public void loadEmployer()
        {
            try
            {
                int i = 0;
                dgvEmployer.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbEmployer WHERE CONCAT (name,address,role) LIKE '%" + txtSearch.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    Console.WriteLine(dr[i]);
                    dgvEmployer.Rows.Add(i, dr[0].ToString(), dr[1], dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[7].ToString()).ToShortDateString(), dr[8].ToString(), dr[5].ToString(), dr[6].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            EmployerModule module = new EmployerModule(this);
            module.btnUpdate.Enabled = false;
            module.ShowDialog();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            loadEmployer();
        }
    }
}

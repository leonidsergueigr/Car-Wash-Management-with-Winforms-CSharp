using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionnaireStationDeLavage
{
    public partial class EmployerModule : Form
    {

        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        bool check = false;
        string title = "Gestionnaire de station de lavage";
        byte[] imageBytes;
        Employer employer;

        public EmployerModule(Employer emp)
        {
            InitializeComponent();
            employer = emp;
            txtSalary.KeyPress += new KeyPressEventHandler(txtSalary_KeyPress);
            txtPhone.KeyPress += new KeyPressEventHandler(txtPhone_KeyPress);
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicturePreview.Image = Image.FromFile(openFileDialog.FileName);
                pbPicturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private static int checkAge(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        public void checkField()
        {
            if (txtAddress.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtSalary.Text == "" || pbPicturePreview == null)
            {
                MessageBox.Show("Veuillez remplir les champs", "Warning");
                return;
            }

            if (checkAge(dtDob.Value) < 18)
            {
                MessageBox.Show("L'employer ne dois pas être mineur!", "Warning");
                return;
            }
            check = true;
        }

        public void Clear()
        {
            txtAddress.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSalary.Clear();

            dtDob.Value = DateTime.Now;
            cbRole.SelectedIndex = 3;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Etes vous sûr de vouloir enregistrer cet employé?", "Employer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        if (pbPicturePreview.Image != null)
                        {
                            
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pbPicturePreview.Image.Save(ms, pbPicturePreview.Image.RawFormat);
                                imageBytes = ms.ToArray();
                            }
                        }
                        cm = new SqlCommand("INSERT INTO tbEmployer(image,name,phone,address,dob,gender,role,salary)VALUES(@image,@name,@phone,@address,@dob,@gender,@role,@salary)", dbcon.connect());
                        cm.Parameters.AddWithValue("@image", imageBytes);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtDob.Value);
                        cm.Parameters.AddWithValue("@gender", rdMale.Checked ? "Homme" : "Femme");
                        cm.Parameters.AddWithValue("@role", cbRole.Text);
                        cm.Parameters.AddWithValue("@salary", txtSalary.Text);

                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("L'employé a bien été enregistré!", title);
                        check = false;
                        Clear();                      
                        employer.loadEmployer();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployerModule_Load(object sender, EventArgs e)
        {

        }

        private void pbPicturePreview_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {

                    if (MessageBox.Show("Etes vous sûr de vouloir modifier cet employé?", "Modification de l'employer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (pbPicturePreview.Image != null)
                        {

                            using (MemoryStream ms = new MemoryStream())
                            {

                                using (Bitmap bmp = new Bitmap(pbPicturePreview.Image))
                                {
                                    bmp.Save(ms, ImageFormat.Jpeg);
                                    imageBytes = ms.ToArray();
                                }
                            }
                        }
                        cm = new SqlCommand("UPDATE tbEmployer SET image=@image,name=@name,phone=@phone,address=@address,dob=@dob,gender=@gender,role=@role,salary=@salary WHERE id=@id", dbcon.connect());
                        
                        cm.Parameters.AddWithValue("@id", Eid.Text);
                        cm.Parameters.AddWithValue("@image", imageBytes);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtDob.Value);
                        cm.Parameters.AddWithValue("@gender", rdMale.Checked ? "Homme" : "Femme");
                        cm.Parameters.AddWithValue("@role", cbRole.Text);
                        decimal salary;
                        if (decimal.TryParse(txtSalary.Text, out salary))
                        {
                            cm.Parameters.AddWithValue("@salary", salary);
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrer un salaire valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("L'employé a bien été modifié!", title);
                        check = false;
                        Clear();
                        this.Dispose();
                        employer.loadEmployer();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }
    }

}

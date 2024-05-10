using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                actualizationPatientBindingSource.DataSource = dataContext.ActualizationPatients.ToList();
            }
            grpCtrls.Enabled = true;
            ActualizationPatient actualizationPatient = actualizationPatientBindingSource.Current as ActualizationPatient;

        }

        private void bttSave_Click(object sender, EventArgs e)
        {
           
           
                using (DataContext dataContext = new DataContext())
                {
                    ActualizationPatient actualizationPatient = actualizationPatientBindingSource.Current as ActualizationPatient;
                    if (actualizationPatient != null)
                    {
                        if (dataContext.Entry<ActualizationPatient>(actualizationPatient).State == EntityState.Detached)
                            dataContext.Set<ActualizationPatient>().Attach(actualizationPatient);
                        if (actualizationPatient.ID == 0)
                            dataContext.Entry<ActualizationPatient>(actualizationPatient).State = EntityState.Added;
                        else
                            dataContext.Entry<ActualizationPatient>(actualizationPatient).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MessageBox.Show("Registro guardado");
                        grpCtrls.Enabled = true;
                    }
                }
            }
        }
    }

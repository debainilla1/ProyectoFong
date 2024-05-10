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

        private void bttAdd_Click(object sender, EventArgs e)
        {
            
                grpCtrls.Enabled = true;
                actualizationPatientBindingSource.Add(new ActualizationPatient());
                actualizationPatientBindingSource.MoveLast();
                txtPatientCode.Focus();
            }

        private void bttCancel_Click(object sender, EventArgs e)
        {
           
                grpCtrls.Enabled = true;
                actualizationPatientBindingSource.ResetBindings(false);
                Form1_Load(sender, e);
            }

        private void bttEdit_Click(object sender, EventArgs e)
        {
           
                grpCtrls.Enabled = true;
                txtPatientCode.Focus();
                ActualizationPatient actualizationPatient = actualizationPatientBindingSource.Current as ActualizationPatient;
            }

        private void bttDelete_Click(object sender, EventArgs e)
        {
          
                if (MessageBox.Show("Quieres eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (DataContext dataContext = new DataContext())
                    {
                        ActualizationPatient actualizationPatient = actualizationPatientBindingSource.Current as ActualizationPatient;
                        if (actualizationPatient != null)
                        {
                            if (dataContext.Entry<ActualizationPatient>(actualizationPatient).State == EntityState.Detached)
                                dataContext.Set<ActualizationPatient>().Attach(actualizationPatient);
                            dataContext.Entry<ActualizationPatient>(actualizationPatient).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            MessageBox.Show("Registro Eliminado");
                            actualizationPatientBindingSource.RemoveCurrent();
                            grpCtrls.Enabled = false;
                        }
                    }
                }
            }
        }
    }
    
    
    

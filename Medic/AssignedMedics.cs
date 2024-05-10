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
    public partial class AssignedMedics : Form
    {
        public AssignedMedics()
        {
            InitializeComponent();
        }

        private void PatientCode_Click(object sender, EventArgs e)
        {

        }

        private void AssignedMedics_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                assignedMedicBindingSource.DataSource = dataContext.AssignedMedics.ToList();
            }
            grpCtrls.Enabled = true;
            AssignedMedic assignedMedic = assignedMedicBindingSource.Current as AssignedMedic;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
           
                using (DataContext dataContext = new DataContext())
                {
                    AssignedMedic assignedMedic = assignedMedicBindingSource.Current as AssignedMedic;
                    if (assignedMedic != null)
                    {
                        if (dataContext.Entry<AssignedMedic>(assignedMedic).State == EntityState.Detached)
                            dataContext.Set<AssignedMedic>().Attach(assignedMedic);
                        if (assignedMedic.ID == 0)
                            dataContext.Entry<AssignedMedic>(assignedMedic).State = EntityState.Added;
                        else
                            dataContext.Entry<AssignedMedic>(assignedMedic).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MessageBox.Show("Registro guardado");
                        grpCtrls.Enabled = true;
                    }
                }
            }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            
                grpCtrls.Enabled = true;
                assignedMedicBindingSource.ResetBindings(false);
                AssignedMedics_Load(sender, e);
            
        }
    }
    }


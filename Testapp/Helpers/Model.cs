using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testapp.Helpers
{
    public class Model
    {
        private bool _isNew = false;
        public bool isSaveable = true;
        public bool isDirty = false;

        public bool canSave() {
            return isNew || isDirty;
        }

        int id = -1;
        [Display(AutoGenerateField = false)]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Display(AutoGenerateField = false)]
        public bool isNew
        {
            get {
                if (id > -1)
                    return false;
                else return true;
            }
            set { _isNew = value; }
        }

        public Model()
        {
            isNew = true;
        }
    }
}

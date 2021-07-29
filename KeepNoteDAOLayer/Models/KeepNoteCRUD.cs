using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepNoteDAOLayer.Models
{
    class KeepNoteCRUD
    {
        List<Category> Categories = null;
        public KeepNoteCRUD()
        {
            if(Categories==null)
            {
                Categories = new List<Category>()
                {
                     new Category() { }
                }
            }
           
        }
        public int InsertNotes(Notes notes)
        {

        }
        public List<Notes> GetAllNotes()
        {

        }
        public Notes GetNoteById(int id)
        {

        }
        public int UpdateNotes(int id, string title)
        {

        }


    }
}

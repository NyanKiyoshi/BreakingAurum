using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSidebar
{
    public class MaterialSidebarEntryCollection : CollectionBase
    {
        public MaterialSidebarEntry this[int Index]
        {
            get
            {
                return (MaterialSidebarEntry)List[Index];
            }
        }

        public int Add(MaterialSidebarEntry itemType)
        {
            return List.Add(itemType);
        }

        public void Remove(MaterialSidebarEntry itemType)
        {
            List.Remove(itemType);
        }

        public void Insert(int index, MaterialSidebarEntry itemType)
        {
            List.Insert(index, itemType);
        }

        public int IndexOf(MaterialSidebarEntry itemType)
        {
            return List.IndexOf(itemType);
        }
    }
}

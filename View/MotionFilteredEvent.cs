using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    internal class MotionFilteredEvent : EventArgs
    {
        public BindingList<MotionBase> FilteredMotionList { get; }

        public MotionFilteredEvent(BindingList<MotionBase>
            filteredMotionList)
        {
            if (filteredMotionList == null)
            {
                throw new ArgumentNullException();
            }

            FilteredMotionList = filteredMotionList;
        }
    }
}

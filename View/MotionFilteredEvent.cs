using System.ComponentModel;
using Model;

namespace View
{
    /// <summary>
    /// Класс события фильтрации.
    /// </summary>
    internal class MotionFilteredEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения отфильтрованного списка.
        /// </summary>
        public BindingList<MotionBase> FilteredMotionList { get; }

        /// <summary>
        /// Конструктор класса MotionFilteredEvent.
        /// </summary>
        /// <param name="filteredMotionList"></param>
        /// <exception cref="ArgumentNullException"></exception>
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

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
        /// <param name="filteredMotionList">Отфильтрованный список.</param>
        /// <exception cref="ArgumentNullException">Исключение.</exception>
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

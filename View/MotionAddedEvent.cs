using System;
using Model;

namespace View
{
    /// <summary>
    /// Класс события добавления движения.
    /// </summary>
    internal class MotionAddedEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения движения.
        /// </summary>
        public MotionBase MotionBase { get; }

        /// <summary>
        /// Конструктор класса MotionAddedEvent.
        /// </summary>
        /// <param name="motionBase"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MotionAddedEvent(MotionBase motionBase)
        {
            if (motionBase == null)
            {
                throw new ArgumentNullException();
            }

            MotionBase = motionBase;
        }
    }
}
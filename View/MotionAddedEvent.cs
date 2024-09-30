using System;
using Model;

namespace View
{
    internal class MotionAddedEvent : EventArgs
    {
        public MotionBase MotionBase { get; }

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
using System;

namespace Информационная_система_проектной_организации.CustomElements
{
    public class Animation
    {
        public string ID { get; set; }

        public float Value;

        public float StartValue;

        public float targetValue;
        public float TargetValue
        {
            get => targetValue;
            set
            {
                targetValue = value;
                Reverse = value < Value ? true : false;
            }
        }
        public AnimStatus Status { get; set; }
        public enum AnimStatus
        {
            Requested,
            Active,
            Completed,
        }


        public float Volume;

        public float Step()
        {
            return Math.Abs(Volume) / 15;
        }
        public bool Reverse = false;

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;
        public Animation()
        { }
        public Animation(string ID, ControlMethod InvalidateControl, float Value, float TargetValue)
        {
            this.ID = ID;
            this.Value = Value;
            this.TargetValue = TargetValue;
            this.InvalidateControl = InvalidateControl;
            StartValue = Value;
            Volume = TargetValue - Value;
        }

        public void UpdateFrame()
        {
            Status = AnimStatus.Active;
            if (!Reverse)
            {
                if(Value <= TargetValue)
                {
                    Value += Step();
                    if (Value >= TargetValue)
                    {
                        Value = TargetValue;
                        Status = AnimStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= TargetValue)
                {
                    Value -= Step();
                    if (Value <= TargetValue)
                    {
                        Value = TargetValue;
                        Status = AnimStatus.Completed;
                    }
                }
            }
            InvalidateControl.Invoke();
        }
    }
}

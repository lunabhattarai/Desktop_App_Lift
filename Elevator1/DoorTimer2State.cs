using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DoorTimer2StateConcreteClass : ILiftState
    {
        private Form1 form;

        public DoorTimer2StateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }
        public void DoorTimer2(Lift lift)
        {
            if (lift.opening2)
            {
                if (lift.Doorleft2.Left > lift.doormaxopenwidth / 2 + 90)
                {
                    lift.Doorleft2.Left -= lift.doorspeed;
                    lift.Doorright2.Left += lift.doorspeed;
                    lift.Btnclose.Enabled = false;
                    lift.Btnf.Enabled = false;
                    lift.Btng.Enabled = false;
                    lift.Btnfirst.Enabled = false;
                    lift.Btnground.Enabled = false;
                }
                else
                {
                    lift.Doortimer2.Stop();
                    lift.Btnclose.Enabled = true;
                    lift.Btnf.Enabled = true;
                    lift.Btng.Enabled = true;
                    lift.Btnfirst.Enabled = true;
                    lift.Btnground.Enabled = true;
                    lift.doorsclosed = false; 
                }
            }
            if (lift.closing2)
            {
                if (lift.Doorleft2.Right < lift.Mainelevator.Width + lift.doormaxopenwidth / 2 + 50)
                {
                    lift.Doorleft2.Left += lift.doorspeed;
                    lift.Doorright2.Left -= lift.doorspeed;
                    lift.Btnopen.Enabled = false;
                    lift.Btnf.Enabled = false;
                    lift.Btng.Enabled = false;
                    lift.Btnfirst.Enabled = false;
                    lift.Btnground.Enabled = false;
                }
                else
                {
                    lift.Doortimer2.Stop();
					lift.Lifttimer.Start();

					lift.Btnopen.Enabled = true;
                    lift.Btnf.Enabled = true;
                    lift.Btng.Enabled = true;
                    lift.Btnfirst.Enabled = true;
                    lift.Btnground.Enabled = true;
                    lift.doorsclosed = true; 
                }
            }
        }

        public void OpenButton(Lift lift) { }
        public void CloseButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
    }
}
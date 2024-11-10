using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DoorTimer1StateConcreteClass : ILiftState
    {
        private Form1 form;

        public DoorTimer1StateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void DoorTimer1(Lift lift)
        {
            if (lift.opening1)
            {
                if (lift.Doorleft1.Left > lift.doormaxopenwidth / 2 + 90)

                {
                    lift.Doorleft1.Left -= lift.doorspeed;
                    lift.Doorright1.Left += lift.doorspeed;
                    lift.Btnclose.Enabled = false;
                    lift.Btnf.Enabled = false;
                    lift.Btng.Enabled = false;
                    lift.Btnfirst.Enabled = false;
                    lift.Btnground.Enabled = false;
                    
                }
                else
                {
                   

                    lift.Doortimer1.Stop();
                    lift.Btnclose.Enabled = true;
                    lift.Btnf.Enabled = true;
                    lift.Btng.Enabled = true;
                    lift.Btnfirst.Enabled = true;
                    lift.Btnground.Enabled = true;
                    lift.doorsclosed = false;

                    lift.Upgif.Visible = false;
                    lift.Floor1.Visible = true;
                }
            }
            if (lift.closing1)
            {
                if (lift.Doorleft1.Right < lift.Mainelevator.Width + lift.doormaxopenwidth / 2 + 50)
                {
                    lift.Doorleft1.Left += lift.doorspeed;
                    lift.Doorright1.Left -= lift.doorspeed;
                    lift.Btnopen.Enabled = false;
                    lift.Btnf.Enabled = false;
                    lift.Btng.Enabled = false;
                    lift.Btnfirst.Enabled = false;
                    lift.Btnground.Enabled = false;
                }
                else
                {
                    lift.Doortimer1.Stop();
                    lift.Btnopen.Enabled = true;
                    lift.Btnf.Enabled = true;
                    lift.Btng.Enabled = true;
                    lift.Btnfirst.Enabled = true;
                    lift.Btnground.Enabled = true;
                    lift.doorsclosed = true;
                    lift.Upgif.Visible = false;
                    lift.Floor1.Visible = true;
                }
            }
        }

        public void OpenButton(Lift lift) { }
        public void CloseButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{

    internal class CloseButtonStateConcreteClass : ILiftState
    {
        private Form1 form;

        public CloseButtonStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void CloseButton(Lift lift)
        {
            if (lift.Mainelevator.Bottom == lift.Ffloor.Bottom) 
            {
                lift.opening2 = false;
                lift.closing2 = true;
                lift.Doortimer2.Start();
                lift.Btnopen.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Door Closes");
            }
            else if (lift.Mainelevator.Bottom == lift.Gfloor.Bottom) 
            {
                lift.opening1 = false;
                lift.closing1 = true;
                lift.Doortimer1.Start();
                lift.Btnopen.Enabled = false;
                lift.Btnf.Enabled = false;
                lift.Btng.Enabled = false;
                lift.Btnfirst.Enabled = false;
                lift.Btnground.Enabled = false;
                form.logEvents("Door Closes");
            }
            else
            {
                form.logEvents("Doors Close");
            }
        }

        public void OpenButton(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }

}
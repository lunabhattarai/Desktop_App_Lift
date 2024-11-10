using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class LiftTimerStateConcreteClass : ILiftState
    {
        private Form1 form;

        public LiftTimerStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }
        public void LiftTimer(Lift lift)
        {
            if (lift.movingup)
            {
                lift.Doortimer1.Start();
                lift.Btng.Enabled = false;
                lift.Btnopen.Enabled = false;
                lift.Btnclose.Enabled = false;
                lift.Btnground.Enabled = false;
                if (lift.Mainelevator.Top > lift.Ffloor.Top)
                {
                    lift.Mainelevator.Top -= lift.liftspeed;
                }
                else
                {
                    lift.Doortimer1.Stop();
                    lift.Mainelevator.Top = lift.Ffloor.Top;
                    lift.Lifttimer.Stop();
                    lift.Btng.Enabled = true;
                    lift.Btnopen.Enabled = true;
                    lift.Btnclose.Enabled = true;
                    lift.Btnground.Enabled = true;

                    lift.OpenButton();
                    lift.movingup = false;
                }
            }

            if (lift.movingdown)
            {
                lift.Doortimer2.Start();
                lift.Btnfirst.Enabled = false;
                lift.Btnopen.Enabled = false;
                lift.Btnclose.Enabled = false;
                lift.Btnfirst.Enabled = false;
                if (lift.Mainelevator.Top < lift.Gfloor.Top)
                {
                    lift.Mainelevator.Top += lift.liftspeed;
                }
                else
                {
                    lift.Doortimer2.Stop();
                    lift.Lifttimer.Stop();
                    lift.Mainelevator.Top = lift.Gfloor.Top;
                    lift.Btnf.Enabled = true;
                    lift.Btnopen.Enabled = true;
                    lift.Btnclose.Enabled = true;
                    lift.Btnfirst.Enabled = true;

                    lift.OpenButton();
                    lift.movingup = false;
                }
            }
        }
        public void CloseButton(Lift lift) { }
        public void OpenButton(Lift lift) { }
        public void MovingDown(Lift lift) { }
        public void MovingUp(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}
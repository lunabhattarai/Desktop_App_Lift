using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class MovingDownStateConcreteClass : ILiftState
    {
        public void MovingUp(Lift lift)
        {
        }

        private Form1 form;

        public MovingDownStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void MovingDown(Lift lift)
        {
            if (lift.Mainelevator.Bottom != lift.Gfloor.Bottom) 
            {
                if (!(lift.doorsclosed))
                {
                    lift.SetState(new CloseButtonStateConcreteClass(form));
                    lift.CloseButton();


					EventHandler doorCloseHandler = null;
                    doorCloseHandler = (s, args) =>
                    {
                        if (lift.doorsclosed)
                        {
                            lift.movingdown = true;
                            lift.movingup = false;
                            lift.Lifttimer.Start();
                            form.logEvents("Lift on Ground Floor");

                            lift.Doortimer1.Tick -= doorCloseHandler;
                        }
                    };
                    lift.Doortimer1.Tick += doorCloseHandler;
                }
                else
                {

					lift.movingdown = true;
                    lift.movingup = false;
                    lift.Lifttimer.Start();
                    form.logEvents("Lift on Ground Floor");

                }

                EventHandler liftMoveHandler = null;
                liftMoveHandler = (s, args) =>
                {
                    if (lift.Mainelevator.Top == lift.Gfloor.Top)
                    {
                        lift.Lifttimer.Stop();
                        lift.SetState(new OpenButtonStateConcreteClass(form));
                        lift.OpenButton();

                        lift.Lifttimer.Tick -= liftMoveHandler;

                        lift.movingup = false;
                        lift.movingdown = false;
                    }
                };
                lift.Lifttimer.Tick += liftMoveHandler;
            }
            else
            {
                lift.Lifttimer.Stop();

                form.logEvents("Lift on Ground Floor");
            }
        }

            public void OpenButton(Lift lift) { }
            public void CloseButton(Lift lift) { }
            public void LiftTimer(Lift lift) { }
            public void DoorTimer1(Lift lift) { }
            public void DoorTimer2(Lift lift) { }
    }
}
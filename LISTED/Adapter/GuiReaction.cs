using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_LISTED.Adapter
{
    public interface GuiUpdate
    {
        public object NewData(); /* new value of subject that caused the notification */
        public void Init(RichTextBox richTextBox);
        public void Reset(RichTextBox richTextBox);
        public void Fill(); /* populate the control */

    }

    public class GuiReaction : GuiUpdate
    {
        public GuiReaction()
        {
            /* constructor */

        }
        void GuiUpdate.Init(RichTextBox richTextBox)
        {
            /* set init values for gui update */
            
        }
        object GuiUpdate.NewData()
        {
            object i = null;
            return i;
        }
        void GuiUpdate.Reset(RichTextBox richTextBox)
        {
            richTextBox.Text = "";
        }
        void GuiUpdate.Fill()
        {

        }

    }

    public class GetGuiReaction : IObserver<GuiReaction>
    {
        private IDisposable unsubscriber;
        private bool first = true;
        private GuiReaction last;

        public virtual void Subscribe(IObservable<GuiReaction> provider)
        {
            /* method to subscribe to given IObservable */
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            /* method to stop message transfer before provider calls method "onCompleted" */
            unsubscriber.Dispose();
        }

        internal void Subscribe(GuiReaction myGuiReaction)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnCompleted()
        {
            /* called method when message transfer is over (good or bad) */
            System.Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception e)
        {
            /* called method when error happened */
            System.Console.WriteLine(e.Message);
        }

        public virtual void OnNext(GuiReaction val)
        {
            /* method provides new data for the observer */

        }
    }
}

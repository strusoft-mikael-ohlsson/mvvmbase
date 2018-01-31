namespace MvvmBase
{
    using System.ComponentModel;

    public class BaseVm
    {
        public virtual void OnClosing(object sender, CancelEventArgs e)
        {
            return;
        }
    }
}
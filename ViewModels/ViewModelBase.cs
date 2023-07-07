using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace EstateAgencyFramework.ViewModels
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected ApplicationContext dbContext = new ApplicationContext();
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public ICommand SaveChangesToDB
        {
            get
            {
                return new CommonCommand(
                () =>
                    {
                        try
                        {
                            dbContext.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                        }
                    }
                , () => true);
            }
        }
    }
}

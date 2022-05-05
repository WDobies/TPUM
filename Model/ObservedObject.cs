using System.ComponentModel;

public abstract class ObservedObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void onPropertyChanged(params string[] propertyNames)
    {
        if(PropertyChanged != null)
        {
            foreach (string propertyName in propertyNames)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}


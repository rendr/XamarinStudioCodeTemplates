[Service]
public class $service_name$ : Service
{
  const string logTag = "$service_name$";
  IBinder binder = null;

  public event EventHandler Changed = delegate{};

  public override IBinder OnBind(Intent intent)
  {
    binder = new $service_name$Binder(this);
    return binder;
  }

  public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
  {
    Log.Debug(logTag, "OnStartCommand: service is running");

    // TODO start doing something

    return StartCommandResult.Sticky;
  }

  public override void OnDestroy()
  {
    Log.Debug(logTag, "OnDestroy: service is stopping");
    // TODO stop doing something
  }

}

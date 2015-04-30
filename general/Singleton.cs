public class $class_name$
	{
		static readonly Lazy<$class_name$> instance = new Lazy<$class_name$>(()=> new $class_name$());

		public static $class_name$ Instance {
			get {return instance.Value;}
		}

    $class_name$(){}
	}

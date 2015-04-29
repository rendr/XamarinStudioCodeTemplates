public class $class_name$Adapter : BaseAdapter<$class_name$>
	{
		WeakReference _activity;
		List<$class_name$> _items;

		public InstructorAdapter (Activity activity, List<$class_name$> items)
		{
			_activity = new WeakReference(activity);
			_items = instructors;
		}

		public override $class_name$ this[int index] {
			get {
				return _items[index];
			}
		}

		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = _items[position];

			// TODO setup view with recycling
			var view = convertView;
			if(view == null)
			{
				// TODO inflate the view, get the subviews, setup view holder
				// view = (_activity.Target as Activity).LayoutInflater.Inflate(Resource.Layout.InstructorRow, parent, false);
				// var photoImageView = (ImageView)view.FindViewById(Resource.Id.photoImageView) ;

				// view.Tag = new $class_name$ViewHolder(){ Photo = photoImageView };
			}

			var holder = view.Tag as $class_name$ViewHolder;
			// TODO update view elements
			// holder.Photo.SetImageDrawable(Drawable.CreateFromStream((_activity.Target as Activity).Assets.Open(item.ImageUrl), null));


			return view;
		}

		public override int Count {
			get {
				return _items.Count;
			}
		}
		#endregion

	}

	public class $class_name$ViewHolder : Java.Lang.Object {
		// TODO setup view properties
		// public ImageView Photo {get;set;}
	}

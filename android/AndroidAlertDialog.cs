var $name$ = new AlertDialog.Builder(this);
$name$.SetMessage("$message$");
$name$.SetNeutralButton("$button_label$",
  delegate
  {
    // TODO handle button click
  });
$name$.Show();

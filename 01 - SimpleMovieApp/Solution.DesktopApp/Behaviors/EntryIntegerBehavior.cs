namespace Solution.DesktopApp.Behaviors;

public class EntryIntegerBehavior : Behavior<Entry>
{
    protected override void OnAttachedTo(Entry enrty)
    {
        base.OnAttachedTo(enrty);
        enrty.TextChanged += OnTextChanged;
    }

    protected override void OnDetachingFrom(Entry enrty)
    {
        base.OnDetachingFrom(enrty);
        enrty.TextChanged -= OnTextChanged;
    }

    private void OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        var entry = sender as Entry;
        if (string.IsNullOrEmpty(e.NewTextValue)){
            return;
        }

        bool isValid = int.TryParse(e.NewTextValue, out int result);
        entry.Text = isValid ? result.ToString() : e.OldTextValue;

    }
}
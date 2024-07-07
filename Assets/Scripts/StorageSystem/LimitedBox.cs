using System;

public class LimitedBox<T> : Box<T> where T : Item
{
    public LimitedBox(int maxCapicity, T item, int count) : base(item, count)
    {
        SetMaxCapicity(maxCapicity);
    }

    public LimitedBox(int maxCapicity) : base()
    {
        SetMaxCapicity(maxCapicity);
    }

    public int maxCapicity { get; private set; }

    private void SetMaxCapicity(int maxCapicity)
    {
        if (maxCapicity <= 0)
            throw new ArgumentOutOfRangeException();

        this.maxCapicity = maxCapicity;
    }

    public override bool Add(Box<T> addebleBox)
    {
        if (maxCapicity <= Capicity() + addebleBox.Capicity())
            return base.Add(addebleBox);
        else
            return base.Add(new Box<T>(item, MaxItemCount() - count));
    }

    private int MaxItemCount()
    {
        return (int)Math.Floor((double)maxCapicity / item.size);
    }

}
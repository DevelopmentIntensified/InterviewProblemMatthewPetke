public interface Shape 
{
    public string Name { get; }
    public int MinHeight { get; }
    public int MaxHeight { get; }
    public void Display(int heightOfShape, char charForShape);
}

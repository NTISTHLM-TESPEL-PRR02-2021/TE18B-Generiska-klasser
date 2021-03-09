using System;

namespace GeneriskaKlasser
{
  public class GridSquare<T>
  {
    public GridSquare<T> top;
    public GridSquare<T> bottom;
    public GridSquare<T> left;
    public GridSquare<T> right;

    public int cost;
    public int height;

    public T content;    
  }
}

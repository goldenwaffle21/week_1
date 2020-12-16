namespace ShapeWorld

class Rectangle : Shape
{
  Rectangle(float v, float h)
  {
    float vertical = v;
    float horizontal = h;
  }
  int lines = 4;
  int corners = 4;
  internal override double Surface()
  {
    return = vertical*horizontal;
  }
  internal override double Volume()
  {
    return 0;
  }
}

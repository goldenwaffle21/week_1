namespace ShapeWorld

class Circle : Shape
{
  Circle(float radius)
  {
    float radius = radius;
  }
  internal override double Surface()
  {
    return 3.1415*radius*radius;
  }
  internal override double Volume()
  {
    return 0;
  }
}

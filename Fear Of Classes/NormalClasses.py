class Shape:
    def draw(self):
        raise NotImplemented("Subclasses of Shape should implement method 'draw'.")

class Circle(Shape):
    def __init__(self, center, radius):
        self.center = center
        self.radius = radius

    def draw(self):
        # Draw a circle...

class Rectangle(Shape):
    def __init__(self, pos, width, height):
        self.pos = pos
        self.width = width
        self.height = height

    def draw(self):
        # Draw a rectangle..
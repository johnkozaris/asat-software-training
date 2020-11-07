class Shape:
    def __init__(self, shape_type, *args):
        self.shape_type = shape_type
        self.args = args

    def draw(self):
        if self.shape_type == "circle":
            center = self.args[0]
            radius = self.args[1]
            # Draw a circle...
        elif self.shape_type == "rectangle":
            pos = self.args[0]
            width = self.args[1]
            height = self.args[2]
            # Draw rectangle...
CREATE TABLE Sizes (
    SizeName VARCHAR(10)
);

CREATE TABLE Colors (
    ColorName VARCHAR(20)
);

INSERT INTO Sizes VALUES
('S'),
('M'),
('L');

INSERT INTO Colors VALUES
('Red'),
('Blue');

SELECT *
FROM Sizes
CROSS JOIN Colors;

using System;

public class Quaternion
{
    public double W { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public double Magnitude()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        double mag = Magnitude();
        double magSquared = mag * mag;
        return new Quaternion(W / magSquared, -X / magSquared, -Y / magSquared, -Z / magSquared);
    }

    public static Quaternion operator +(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
    }

    public static Quaternion operator -(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
    }

    public static Quaternion operator *(Quaternion q1, Quaternion q2)
    {
        double w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
        double x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
        double y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
        double z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;
        return new Quaternion(w, x, y, z);
    }

    public static bool operator ==(Quaternion q1, Quaternion q2)
    {
        return q1.Equals(q2);
    }

    public static bool operator !=(Quaternion q1, Quaternion q2)
    {
        return !q1.Equals(q2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Quaternion other)
        {
            return W == other.W && X == other.X && Y == other.Y && Z == other.Z;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(W, X, Y, Z);
    }

    public double[,] ToRotationMatrix()
    {
        double[,] rotationMatrix = new double[3, 3];
        double ww = W * W;
        double wx = W * X;
        double wy = W * Y;
        double wz = W * Z;
        double xx = X * X;
        double xy = X * Y;
        double xz = X * Z;
        double yy = Y * Y;
        double yz = Y * Z;
        double zz = Z * Z;

        rotationMatrix[0, 0] = ww + xx - yy - zz;
        rotationMatrix[0, 1] = 2 * (xy - wz);
        rotationMatrix[0, 2] = 2 * (xz + wy);
        rotationMatrix[1, 0] = 2 * (xy + wz);
        rotationMatrix[1, 1] = ww - xx + yy - zz;
        rotationMatrix[1, 2] = 2 * (yz - wx);
        rotationMatrix[2, 0] = 2 * (xz - wy);
        rotationMatrix[2, 1] = 2 * (yz + wx);
        rotationMatrix[2, 2] = ww - xx - yy + zz;

        return rotationMatrix;
    }

    public static Quaternion FromRotationMatrix(double[,] matrix)
    {
        if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
        {
            throw new ArgumentException("Rotation matrix must be 3x3.");
        }

        double trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        double w, x, y, z;

        if (trace > 0)
        {
            double S = Math.Sqrt(trace + 1.0) * 2;
            w = 0.25 * S;
            x = (matrix[2, 1] - matrix[1, 2]) / S;
            y = (matrix[0, 2] - matrix[2, 0]) / S;
            z = (matrix[1, 0] - matrix[0, 1]) / S;
        }
        else if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
        {
            double S = Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]) * 2;
            w = (matrix[2, 1] - matrix[1, 2]) / S;
            x = 0.25 * S;
            y = (matrix[0, 1] + matrix[1, 0]) / S;
            z = (matrix[0, 2] + matrix[2, 0]) / S;
        }
        else if (matrix[1, 1] > matrix[2, 2])
        {
            double S = Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]) * 2;
            w = (matrix[0, 2] - matrix[2, 0]) / S;
            x = (matrix[0, 1] + matrix[1, 0]) / S;
            y = 0.25 * S;
            z = (matrix[1, 2] + matrix[2, 1]) / S;
        }
        else
        {
            double S = Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]) * 2;
            w = (matrix[1, 0] - matrix[0, 1]) / S;
            x = (matrix[0, 2] + matrix[2, 0]) / S;
            y = (matrix[1, 2] + matrix[2, 1]) / S;
            z = 0.25 * S;
        }

        return new Quaternion(w, x, y, z);
    }

    public override string ToString()
    {
        return $"({W}, {X}, {Y}, {Z})";
    }
}

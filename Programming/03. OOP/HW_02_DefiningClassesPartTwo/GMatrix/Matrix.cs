using System;
using System.Text;

namespace GMatrix
{
    public class Matrix<T> where T : IComparable
    {
        //Fields
        private readonly int cols;
        private readonly int rows;
        private readonly T[,] matrix;

        //Constructors
        public Matrix(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            matrix = new T[cols, rows];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            cols = matrix.GetLength(0);
            rows = matrix.GetLength(1);
        }

        //Properties
        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        //Indexer
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0 || col > cols || row > rows)
                {
                    throw new IndexOutOfRangeException();
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0 || col > cols || row > rows)
                {
                    throw new IndexOutOfRangeException();
                }
                matrix[row, col] = value;
            }
        }

        #region Operator overloads
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new Exception("The matrices are with different rows, colums or both");
            }
            Matrix<T> result = new Matrix<T>(first.rows, first.cols);
            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new Exception("The matrices are with different rows, colums or both");
            }
            Matrix<T> result = new Matrix<T>(first.rows, first.cols);
            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.rows != second.rows || first.cols != second.cols)
            {
                throw new Exception("The matrices are with different rows, colums or both");
            }
            Matrix<T> result = new Matrix<T>(first.rows, first.cols);
            for (int row = 0; row < result.rows; row++)
            {
                for (int col = 0; col < result.cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] * second[row, col];
                }
            }
            return result;
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        //Method
        //Not asked to do, but for easier testing
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result.Append(matrix[row, col] + " ");
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}

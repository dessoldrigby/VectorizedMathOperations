﻿


namespace Vectorized_Math_Operations;

internal interface IMatrix<T> : IEnumerable<T>
        where T : struct
{
    public bool IsEmpty { get; }
    public T this[int idx] { get; set; }
    public T this[int idxX, int idxY] { get; set; }

    public IMatrix<T> Copy();
    public void FillWith(T value, int howMane = 0);
    public void Append(IMatrix<T> matrix);
    public IMatrix<T> Transpose();
}

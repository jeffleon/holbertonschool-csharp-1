﻿using System;

class MatrixMath
{
	/// <summary>
	/// Transposes a matrix.
	/// </summary>
	/// <param name="matrix">The matrix.</param>
	/// <returns>The new, transposed matrix.</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		double[,] newMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			for (int j = 0; j < matrix.GetLength(0); j++)
			{
				newMatrix[i, j] = matrix[j, i];
			}
		}
		return (newMatrix);
	}
}

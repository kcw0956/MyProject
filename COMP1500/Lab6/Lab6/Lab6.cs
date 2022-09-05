namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] array)
        {
            int lengthY = array.GetLength(0);
            int lengthX = array.GetLength(1);

            int[,] targetArray = new int[lengthX, lengthY];

            for (int y = 0; y < lengthY; y++)
            {
                for (int x = 0; x < lengthX; x++)
                {
                    targetArray[x, y] = array[lengthY - 1 - y, x];
                }
            }

            return targetArray;
        }

        public static void TransformArray(int[,] array, EMode function)
        {
            int lengthY = array.GetLength(0);
            int lengthX = array.GetLength(1);

            int[,] targetArray = new int[lengthY, lengthX];

            switch (function)
            {
                case EMode.HorizontalMirror:
                    for (int y = 0; y < lengthY; y++)
                    {
                        for (int x = 0; x < (lengthX); x++)
                        {
                            targetArray[y, x] = array[y, lengthX - 1 - x];
                        }
                    }
                    break;
                case EMode.VerticalMirror:
                    for (int y = 0; y < (lengthY); y++)
                    {
                        for (int x = 0; x < lengthX; x++)
                        {
                            targetArray[y, x] = array[lengthY - 1 - y, x];
                        }
                    }
                    break;
                case EMode.DiagonalShift:
                    for (int y = 0; y < lengthY; ++y)
                    {
                        for (int x = 0; x < lengthX; ++x)
                        {
                            if (y >= lengthY - 1 && x < lengthX - 1)
                            {
                                targetArray[y, x] = array[lengthY - 1 - y, x];
                            }
                            else if (x >= lengthX - 1 && y < lengthY - 1)
                            {
                                targetArray[y, x] = array[lengthY - 1 - y, x];
                            }
                            else if (y >= lengthY - 1 && x >= lengthX - 1)
                            {
                                targetArray[0, 0] = array[y, x];
                            }
                            else
                            {
                                targetArray[y + 1, x + 1] = array[x, y];
                            }
                        }
                    }
                    break;
            }
        }

    }

  
}
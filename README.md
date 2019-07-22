# MatrixOfIslands
Test Task 'Matrix of Islands'

Algorithm:
1. Go through the matrix (starting from the very top, left to right)
2. For each cell look at the values on the left and on the top of the current cell
3. If top and left values both are 0 - this is a new island (do increment)
4. If top and left values both are 1 - this island is a part of another island (do decrement)

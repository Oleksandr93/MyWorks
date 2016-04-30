<?php
/****************
4x + 7y + 2z = 34 
3x + 1y + 5z = 21 
8x + 2y + 6z = 52 
 ****************/
$matrix[0] = array(4, 7, 2);
$matrix[1] = array(3, 1, 5);
$matrix[2] = array(8, 2, 6);
$b[0] = 34;
$b[1] = 21;
$b[2] = 52;
// Решаем уравнение 
list($x, $y, $z) = solve($matrix, $b);
echo "Решение<br />";
echo "X = $x<br />";
echo "Y = $y<br />";
echo "Z = $z<br />";
// Проверка 
echo 4 * $x + 7 * $y + 2 * $z;
echo "<br>";
echo 3 * $x + 1 * $y + 5 * $z;
echo "<br>";
echo 8 * $x + 2 * $y + 6 * $z;

function solve($matrix, $b)
{
    // Вычисляем детерминант исходной матрицы 
    $determinant = determinant($matrix);
    // Формируем детерминант для переменных 
    for($i = 0; $i < 3; $i++)
    {
        $xd[$i] = $matrix[$i];
        $xd[$i][0] = $b[$i];
        $yd[$i] = $matrix[$i];
        $yd[$i][1] = $b[$i];
        $zd[$i] = $matrix[$i];
        $zd[$i][2] = $b[$i];
    }
    $x = determinant($xd) / $determinant;
    $y = determinant($yd) / $determinant;
    $z = determinant($zd) / $determinant;

    return array($x, $y, $z);
}
// Детерминант трехмерной матрицы 
function determinant($m)
{
    return $m[0][0] * ($m[1][1] * $m[2][2] - $m[2][1] * $m[1][2]) -
    $m[0][1] * ($m[1][0] * $m[2][2] - $m[2][0] * $m[1][2]) +
    $m[0][2] * ($m[1][0] * $m[2][1] - $m[2][0] * $m[1][1]);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Insertion Sort Dry Run</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
        }
        .code {
            background-color: #f4f4f4;
            padding: 10px;
            border: 1px solid #ccc;
            margin-bottom: 10px;
            white-space: pre;
        }
        h2 {
            color: #2d89ef;
        }
        h3 {
            color: #1e7145;
        }
    </style>
</head>
<body>

    <h2>Insertion Sort Dry Run</h2>
    
    <h3>Initial Array:</h3>
    <div class="code">[7, 4, 5, 2]</div>

    <h3>Pass 1:</h3>
    <div class="code">
        i = 1, key = 4, j = 0
        Compare key with array[j] (4 &lt; 7), so shift 7 to the right.
        Array becomes: [7, 7, 5, 2]
        j becomes -1 (exit loop).
        Insert key (4) at array[j + 1] → array[0] = 4
        Array after Pass 1: [4, 7, 5, 2]
    </div>

    <h3>Pass 2:</h3>
    <div class="code">
        i = 2, key = 5, j = 1
        Compare key with array[j] (5 &lt; 7), so shift 7 to the right.
        Array becomes: [4, 7, 7, 2]
        j becomes 0.
        Compare key with array[j] (5 &gt;= 4), so stop shifting.
        Insert key (5) at array[j + 1] → array[1] = 5
        Array after Pass 2: [4, 5, 7, 2]
    </div>

    <h3>Pass 3:</h3>
    <div class="code">
        i = 3, key = 2, j = 2
        Compare key with array[j] (2 &lt; 7), so shift 7 to the right.
        Array becomes: [4, 5, 7, 7]
        j becomes 1.
        Compare key with array[j] (2 &lt; 5), so shift 5 to the right.
        Array becomes: [4, 5, 5, 7]
        j becomes 0.
        Compare key with array[j] (2 &lt; 4), so shift 4 to the right.
        Array becomes: [4, 4, 5, 7]
        j becomes -1 (exit loop).
        Insert key (2) at array[j + 1] → array[0] = 2
        Array after Pass 3: [2, 4, 5, 7]
    </div>

    <h3>Final Sorted Array:</h3>
    <div class="code">[2, 4, 5, 7]</div>

</body>
</html>

<details>




```c#
public int[] BubbleSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Bubble Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("==========================================\n");

        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            Console.WriteLine($"--- Pass {i + 1} ---");

            for (int j = 0; j < n - i - 1; j++)
            {
                Console.WriteLine($"Comparing index {j} (Element: {arr[j]}) and index {j + 1} (Element: {arr[j + 1]})");

                if (arr[j] > arr[j + 1])
                {
                    Console.WriteLine($"Swapping {arr[j]} and {arr[j + 1]}");
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }

                Console.WriteLine($"Array after comparison: [{string.Join(", ", arr)}]\n");
            }

            if (!swapped)
            {
                Console.WriteLine("No swaps in this pass, the array is sorted.");
                break;
            }
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("========== Bubble Sort Completed ==========\n");

        return arr;
    }

public int[] InsertionSortMethod()
{
    Console.WriteLine("Starting Insertion Sort...");
    int[] array = { 3, 5, 4, 2, 7, 12 };
    Console.WriteLine("Original array: " + string.Join(", ", array));

    int n = array.Length;

    for (int i = 1; i < n; i++)
    {
        Console.WriteLine($"Pass {i + 1}:");
        int key = array[i];  // Element to be inserted
        int j = i - 1;

        // Shift elements of array[0..i-1] that are greater than key
        // to one position ahead of their current position
        Console.WriteLine($"    Comparing {array[j]} and {key}");
        while (j >= 0 && array[j] > key)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Change to red or any color you prefer
            Console.WriteLine($"    Shifting {array[j]} to the right");
            Console.ResetColor(); // Reset to default color

            array[j + 1] = array[j];
            j = j - 1;
        }
        
        Console.WriteLine($"    Current array state before inserting key element: {string.Join(", ", array)}");
        Console.WriteLine($"    Inserting key {key} at position {j + 1}");
        
        // Insert the key at the correct position
        array[j + 1] = key;
        Console.WriteLine($"    Current array state after insertion: {string.Join(", ", array)}");
    }

    Console.ResetColor();
    return array;
}

   public int[] SelectionSortMethod(int[] arr)
    {
        Console.WriteLine("========== Starting Selection Sort ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("=============================================\n");

        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            Console.WriteLine($"--- Pass {i + 1} ---");
            Console.WriteLine($"Starting to find the minimum from index {i} onwards.\n");

            for (int j = i + 1; j < n; j++)
            {
                Console.WriteLine($"Comparing element at index {minIndex} (Element: {arr[minIndex]}) with index {j} (Element: {arr[j]})");

                if (arr[j] < arr[minIndex])
                {
                    Console.WriteLine($"New minimum found at index {j} (Element: {arr[j]})");
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Console.WriteLine($"Swapping element at index {i} (Element: {arr[i]}) with new minimum at index {minIndex} (Element: {arr[minIndex]})");
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine($"Array after Pass {i + 1}: [{string.Join(", ", arr)}]\n");
        }

        Console.WriteLine($"Sorted Array: [{string.Join(", ", arr)}]");
        Console.WriteLine("========== Selection Sort Completed ==========\n");

        return arr;
    }

 public int[] QuickSortMethod(int[] arr, int leftindex, int rightindex)
    {
        var i = leftindex;
        var j = rightindex;
        var pivot = arr[leftindex];

        Console.WriteLine("========== Starting QuickSort Method ==========");
        Console.WriteLine($"Original Array: [{string.Join(", ", arr)}]");
        Console.WriteLine($"Pivot Element: {pivot} (at index {leftindex})");
        Console.WriteLine($"Left Index: {leftindex}, Right Index: {rightindex}");
        Console.WriteLine("===============================================\n");

        while (i <= j)
        {
            Console.WriteLine($"--- Checking element at index {i} ---");
            Console.WriteLine($"Current Element: {arr[i]}, Pivot: {pivot}");

            // Increment index i while arr[i] is less than pivot
            while (arr[i] < pivot)
            {
                Console.WriteLine($"Element {arr[i]} is less than pivot {pivot}, incrementing index i...");
                i++;
            }
            Console.WriteLine($"Stopped incrementing i. Current index i: {i} (Element: {arr[i]})\n");

            // Decrement index j while arr[j] is greater than pivot
            Console.WriteLine($"--- Checking element at index {j} ---");
            Console.WriteLine($"Current Element: {arr[j]}, Pivot: {pivot}");
            while (arr[j] > pivot)
            {
                Console.WriteLine($"Element {arr[j]} is greater than pivot {pivot}, decrementing index j...");
                j--;
            }
            Console.WriteLine($"Stopped decrementing j. Current index j: {j} (Element: {arr[j]})\n");

            // Swap elements at i and j if i <= j
            if (i <= j)
            {
                Console.WriteLine($"Swapping elements at index {i} and {j}...");
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                Console.WriteLine($"Array after swap: [{string.Join(", ", arr)}]");
                Console.WriteLine($"Incrementing i and decrementing j after swap.\n");

                i++;
                j--;
            }
        }

        Console.WriteLine($"New i value: {i}, New j value: {j}");
        Console.WriteLine($"Left Index: {leftindex}, Right Index: {rightindex}\n");

        // Recursively sort left and right sub-arrays
        if (leftindex < j)
        {
            Console.WriteLine($"Recursively sorting left part: indices {leftindex} to {j}\n");
            QuickSortMethod(arr, leftindex, j);
        }
        if (i < rightindex)
        {
            Console.WriteLine($"Recursively sorting right part: indices {i} to {rightindex}\n");
            QuickSortMethod(arr, i, rightindex);
        }

        Console.WriteLine($"Returning sorted array: [{string.Join(", ", arr)}]\n");
        Console.WriteLine("========== QuickSort Method Completed ==========\n");

        return arr;
    }

 public void Heapify(int[] arr, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // left child index
        int right = 2 * i + 2;  // right child index

        // Check if left child exists and is greater than root
        if (left < n && arr[left] > arr[largest])
            largest = left;

        // Check if right child exists and is greater than largest so far
        if (right < n && arr[right] > arr[largest])
            largest = right;

        // If largest is not root, swap with root and continue heapifying
        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }

    public void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public void HeapSortMethod(int[] arr)
    {
        int n = arr.Length;

        // Build a maxheap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // One by one extract elements from heap
        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i, 0);
        }
    }


     public void Merge(int[] array, int left, int mid, int right)
    {
        int leftArrayLength = mid - left + 1;
        int rightArrayLength = right - mid;

        int[] leftArray = new int[leftArrayLength];
        int[] rightArray = new int[rightArrayLength];

        Array.Copy(array, left, leftArray, 0, leftArrayLength);
        Array.Copy(array, mid + 1, rightArray, 0, rightArrayLength);

        int i = 0, j = 0, k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftArrayLength)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightArrayLength)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }


    public void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    
    
    
    
    
scale from zero to million users

Designing a system that supports millions of users is challenging, and it is a journey that requires continuous refinement and endless improvement. In this chapter, we build a system that supports a single user and gradually scale it up to serve millions of users. After reading this chapter, you will master a handful of techniques that will help you to crack the system design interview questions.

system design 
dsa
algo
db
microservices
design pattern
operating system 
logging and metrices
db sharding 
azure
aws
scaling application 
networking
react
javascript 
python
Java

For a software engineer with around 5 years of experience, a data analytics syllabus should be both comprehensive and advanced enough to enable immediate practical application and further specialization. Here’s a structured syllabus you can aim to complete over a 6-9 month period if studying part-time while working, or over a shorter period if dedicating full-time focus.

### 1. **Foundations of Data Analytics**
   - **Duration**: 1-2 weeks
   - **Topics**:
     - Overview of data analytics, data science, and data engineering
     - Types of data (structured, semi-structured, unstructured)
     - Basic statistical concepts (mean, median, mode, variance, standard deviation)
     - Probability basics (distributions, conditional probability, Bayes' theorem)
     - Descriptive vs. Inferential Statistics
   - **Tools**: Jupyter Notebook, Google Colab

### 2. **Data Handling and Preprocessing**
   - **Duration**: 2-3 weeks
   - **Topics**:
     - Data collection techniques and data sources
     - Data cleaning, handling missing values, and data transformation
     - Exploratory Data Analysis (EDA): Outliers, visualizations, and data insights
     - Feature engineering (scaling, encoding categorical variables)
     - Data transformation techniques (normalization, standardization)
   - **Tools**: Pandas, NumPy, OpenRefine

### 3. **Data Visualization**
   - **Duration**: 2 weeks
   - **Topics**:
     - Data visualization theory: choosing appropriate charts for different data types
     - Visualization tools and libraries (Matplotlib, Seaborn, Plotly)
     - Dashboarding basics and storyboarding (communicating insights)
     - Advanced topics (interactive visualizations, geospatial data visualizations)
   - **Tools**: Matplotlib, Seaborn, Plotly, Tableau or Power BI

### 4. **SQL for Data Analytics**
   - **Duration**: 2-3 weeks
   - **Topics**:
     - Basic to intermediate SQL (SELECT, JOIN, GROUP BY, subqueries)
     - Analytical SQL functions (window functions, CTEs)
     - Advanced SQL techniques (roll-ups, cubes, pivot tables)
     - Query optimization and indexing strategies
   - **Tools**: PostgreSQL, MySQL, BigQuery

### 5. **Programming for Data Analytics**
   - **Duration**: 3-4 weeks
   - **Topics**:
     - Python basics for data analytics (functions, loops, conditional logic)
     - Advanced Python libraries for analytics (Pandas, NumPy, Scikit-learn)
     - Functional programming and lambda functions for efficient data manipulation
     - Handling large datasets (chunking, multiprocessing)
   - **Tools**: Python, Jupyter Notebook, Pandas, NumPy

### 6. **Statistical Analysis and Hypothesis Testing**
   - **Duration**: 3 weeks
   - **Topics**:
     - Hypothesis testing (t-tests, chi-square tests, ANOVA)
     - Confidence intervals, p-values, and statistical significance
     - A/B testing and experimental design
     - Advanced regression analysis (linear regression, logistic regression)
   - **Tools**: Python (Scipy, StatsModels)

### 7. **Machine Learning Basics for Analytics**
   - **Duration**: 4-5 weeks
   - **Topics**:
     - Supervised learning basics (classification and regression)
     - Unsupervised learning basics (clustering and dimensionality reduction)
     - Model evaluation and validation (cross-validation, overfitting, underfitting)
     - Basics of neural networks (optional)
   - **Tools**: Scikit-learn, TensorFlow or PyTorch (optional)

### 8. **Big Data Analytics and Cloud Platforms**
   - **Duration**: 3-4 weeks
   - **Topics**:
     - Introduction to big data (concepts, Hadoop, Spark)
     - Data warehousing basics and cloud data platforms
     - Working with cloud-based data analytics tools (AWS, GCP, Azure)
     - Basics of data pipelines and ETL processes
   - **Tools**: Hadoop, Apache Spark, AWS (Athena, Redshift), Google BigQuery, Azure Synapse

### 9. **Business Intelligence and Analytics Applications**
   - **Duration**: 3 weeks
   - **Topics**:
     - Business intelligence concepts and key performance indicators (KPIs)
     - Building analytics dashboards and reports
     - Using BI tools to track metrics and make decisions
     - Advanced data storytelling and reporting
   - **Tools**: Power BI, Tableau, Google Data Studio

### 10. **Capstone Project**
   - **Duration**: 4 weeks
   - **Topics**:
     - Choose a real-world dataset or problem
     - Complete the full data analytics pipeline: from data collection, cleaning, and EDA to modeling and visualization
     - Present findings and insights in a dashboard or a report
   - **Tools**: Combine all learned tools and techniques

### Optional Advanced Topics (For Future Learning)
   - **Deep Learning for Analytics**: Neural networks, CNNs, RNNs
   - **Advanced Machine Learning**: Time series analysis, recommendation systems
   - **Advanced Cloud Analytics**: Serverless architecture, data lakes
   - **Data Ethics and Privacy**: Ethical issues, GDPR, data governance

---

#### **Suggested Learning Plan**
1. **6-9 months part-time**: Completing 10–15 hours a week while working.
2. **3-4 months full-time**: Dedicating 30–40 hours per week.

#### **Recommended Resources**
   - **Courses**: Udacity Data Analyst Nanodegree, Coursera (IBM Data Analyst Professional Certificate, Data Science Specialization by Johns Hopkins), Datacamp
   - **Books**: "Practical Statistics for Data Scientists," "Python for Data Analysis" by Wes McKinney, "Storytelling with Data" by Cole Nussbaumer Knaflic



   DSA Interview Questions on Array
Check if pair with the given Sum exists in Array
Best Time to Buy and Sell Stock
Find duplicates
Product of Array Except Self
Maximum Subarray
Maximum Product Subarray
Find Minimum in Rotated Sorted Array
Search in Rotated Sorted Array
3 Sum
Container With Most Water
Find the Factorial of a large number
Trapping Rain Water
Chocolate Distribution Problem
Insert Interval
Merge Intervals
Non-overlapping Intervals




As of November 2024, .NET 9 has been released, introducing several new features and enhancements across various components of the framework. Here's an overview of the latest updates:

.NET 9 Enhancements:

TitleBar Control for Windows: A new TitleBar control is available for Windows desktop applications, allowing developers to customize the title bar area more easily. 
Microsoft Learn

HybridWebView Control: The HybridWebView control enables the integration of JavaScript-enabled content from frameworks like ReactJS, Vue.js, and Angular into .NET applications, facilitating the development of hybrid applications. 
Microsoft Learn

Entry Control Enhancements: The Entry control now supports additional keyboard modes, improving user input handling across different platforms. 
Microsoft Learn

Automatic Handler Disconnection: Control handlers now automatically disconnect from their controls when possible, enhancing resource management and application performance. 
Microsoft Learn

MainPage Deprecation: The MainPage property is deprecated in favor of overriding the Application.CreateWindow(IActivationState) method to set the primary page of the application, providing a more flexible approach to window management. 
Microsoft Learn

.NET 8 Recap:

Prior to .NET 9, .NET 8 introduced significant improvements:

Performance and Runtime Enhancements: .NET 8 included advancements in performance, garbage collection, and core libraries, along with a new globalization mode for mobile apps and source generators for COM interop and configuration binding. 
Microsoft Learn

C# 12 Integration: C# 12 was released with .NET 8, bringing features like primary constructors, default values for lambda expressions, and type aliasing, enhancing code expressiveness and reducing boilerplate. 
Techcronus

ASP.NET Core Updates: Improvements in Blazor, SignalR, minimal APIs, Native AOT, and server enhancements were part of ASP.NET Core in .NET 8, aiming to streamline web application development. 
Microsoft Learn

Entity Framework Core 8: EF Core 8 introduced support for complex types, collections of primitive types, JSON column mapping, and other features to enhance data access and manipulation. 
Microsoft Learn

Windows Forms and WPF Enhancements: Updates included data binding improvements, DPI support, and new controls like OpenFolderDialog in WPF, enhancing desktop application development. 
Microsoft Learn

Dynamic Programming (DP): Overview
Dynamic Programming (DP) is an optimization technique used to solve problems by breaking them down into overlapping subproblems. Unlike divide-and-conquer, DP stores the results of subproblems to avoid redundant computations, making it ideal for problems with overlapping substructure and optimal substructure properties.

Key Characteristics of DP Problems
----------------------------------
Overlapping Subproblems:

    The problem can be broken into smaller subproblems that are solved multiple times.
    DP avoids recalculating these subproblems by storing results in a table (memoization or tabulation).
Optimal Substructure:

    The solution to a problem can be constructed from the solutions of its subproblems.

Dynamic Programming Approaches
-------------------------------
Memoization (Top-Down):

    Solve the problem recursively.
    Store the results of solved subproblems in a table (cache).
    If the result is already calculated, return it instead of recomputing.
Tabulation (Bottom-Up):

    Solve the problem iteratively.
    Build a table (array or matrix) from smaller subproblems to the final solution.

Steps to Solve a DP Problem
---------------------------
Define the Problem:

    Clearly state the problem and identify the input, output, and constraints.

Identify the Subproblems:

    Break the problem into smaller overlapping problems.
Define the State:

    Determine the variables that uniquely define a subproblem (e.g., dp[i] might represent the solution for the first i elements).
Establish the Recurrence Relation:

    Derive a formula that expresses the solution to a subproblem in terms of smaller subproblems.
Base Cases:

    Define the values for the smallest subproblems (usually trivial cases).
Iterative or Recursive Implementation:

    Choose either a top-down (memoization) or bottom-up (tabulation) approach.
Optimize Space (Optional):

    If the problem allows, reduce the storage by keeping only relevant previous states.

    No study - 26 Nov 2024
    Created Project for testing azure and integration of other parts 
    No Study - 28 Nov 2024
    No Study - 30 Nov 2024 
```

</details>

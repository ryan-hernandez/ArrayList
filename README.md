# ArrayList

<hr>

## **Purpose**

The purpose of this project is to implement the Array List data structure from scratch to better improve my understanding of it as well as to hone my skills. 

The remainder of this document will serve as an explaination of the functionality for each method. 

<hr>

### **Constructor**

The ArrayList class has two constructors, a default constructor, and a constructor that accepts an integer paramater representing the size that the user wishes their array to be initialized at.

The default constructor array size is ten. 

### **Add**

<code>Add(T data)</code> simply adds an element to the end of the list.

### **AddAt**

<code>AddAt(int index, T data)</code> adds the element at the index of the users choice. This function handles two situations that may arise when adding an element at a desired index:

- ##### The user adds an element outside the range of current elements
    - If a user adds an element outside the range of current elements, the array is resized until the index to add at is within range, then the element is inserted, with the variable <code>_index</code> being updated to the index immediately after the insertion. Because of this, if a user adds an element outside the range of current elements, any call to <code>Add()</code> thereafter will place elements at the very end of the array, potentially with many empty values in between.

- ##### The user adds an element within the range of current elements
    - If a user adds an element within the range of current elements, the element is inserted and all elements starting at the index and greater are shifted one index upward. 

### **Count**

<code>Count()</code> returns the number of elements that have been inserted into the array.

### **Get**

<code>Get(int index)</code> returns the element at the specified index.

### **GetEnumerator**

<code>GetEnumerator()</code> implements the IEnumerable function so that ArrayLists can be enumerated with <code>foreach</code> loops.

### **Remove**

<code>Remove()</code> removes an element from the end of the array.

### **RemoveAt**

<code>RemoveAt(int index)</code> removes an element from the specified index.

### **Resize**

<code>Resize()</code> is a function automatically called by the <code>Add()</code> and <code>AddAt(int index, T data)</code> functions to double the size of the array if the current index to insert elements at has reached the end of the array.

### **Print** 

<code>Print()</code> prints a bracketed representation of the Array List to the console.
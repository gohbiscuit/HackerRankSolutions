 /* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

// recursive function to insert a node in BST
static Node Insert(Node root,int value)
{
    if(root == null)
    {
        root = new Node();
        root.data = value;
        root.left = root.right = null;
    }

    // recur down the tree
    if(value < root.data)
    {
        root.left = Insert(root.left, value);
    }
    else if(value > root.data)
    {
        root.right = Insert(root.right, value);
    }

    return  root;
}



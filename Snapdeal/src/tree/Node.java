package tree;

public class Node {
	
	public Node leftNode = null;
	public Node rightNode = null;
	public int value;
	
	public Node() {
		
	}
	
	public Node(Node left, Node right, int val) {
		leftNode = left;
		rightNode = right;
		value = val;		
	}
	
	

}

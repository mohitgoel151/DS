package tree;

import blockingqueue.BlockingQueue;

public class CompareTree {

	public void compare(Node parentTree, Node subTree) {

		if(parentTree == null || subTree == null) {
			System.out.println("One of the tree is null");
			return;
		}

		Node subTreeRoot = returnSubTreeRoot(parentTree, subTree);
		if(subTreeRoot == null) {
			System.out.println("Not a SubTree");
			return;
		}

		boolean isSubTree = isSubTree(subTreeRoot, subTree);
		if(isSubTree == true) {
			System.out.println("It is a SubTree");
		}
		else {
			System.out.println("Not a SubTree");
		}
	}

	private Node returnSubTreeRoot(Node parentTree, Node subTree) {

		if(parentTree == null || subTree == null) {
			System.out.println("One of the tree is null");
			return null;
		}

		Node aNode = searchNode(parentTree, subTree);

		return aNode;
	}


	private Node searchNode(Node parentTreeNode, Node subTree) {
		Node aNode = null;

		if(parentTreeNode == null) {
			return aNode;
		}

		if(parentTreeNode.value == subTree.value) {
			aNode =  parentTreeNode;
		} else if(parentTreeNode.value > subTree.value) {
			aNode =  searchNode(parentTreeNode.leftNode, subTree);
		} else {
			aNode =  searchNode(parentTreeNode.rightNode, subTree);
		}
		return aNode;
	}

	private boolean isSubTree(Node subTreeRoot, Node subTree) {
		boolean isSubTree = false;

		if(subTreeRoot != null && subTree != null) {
			if(subTreeRoot.value == subTree.value) {
				boolean isSubTree1 = isSubTree(subTreeRoot.leftNode, subTree.leftNode);
				if(isSubTree1 = false) {
					return false;
				}
				boolean isSubTree2 = isSubTree(subTreeRoot.rightNode, subTree.rightNode);
				if(isSubTree2 = false) {
					return false;
				}
				isSubTree = true;
			}
		} else if(subTreeRoot == null && subTree == null) {
			isSubTree = true;
		} 

		return isSubTree;
	}

}

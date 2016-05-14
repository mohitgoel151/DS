package tree;

public class LaunchTree {

	public static void main(String[] args) {
	
		CreateTree create = new CreateTree();
		Node parentTree = create.getTree();
		
		Node subTree = create.getTree();
		
		CompareTree compare = new CompareTree();
		compare.compare(parentTree, subTree);

	}

}

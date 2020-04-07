class PeekingIterator implements Iterator<Integer> {

    private final Iterator<Integer> iter;
    private int peekedElement;
    private boolean hasPeeked;
	public PeekingIterator(Iterator<Integer> iterator) {
	    // initialize any member here.
	    this.iter = iterator;
        hasPeeked = false;
	}

    // Returns the next element in the iteration without advancing the iterator.
	public Integer peek() {
        if(!hasPeeked) {
            peekedElement = iter.next();
            hasPeeked = true;
        }
        return peekedElement;
	}

	// hasNext() and next() should behave the same as in the Iterator interface.
	// Override them if needed.
	@Override
	public Integer next() {
	    if(!hasPeeked) {
            return iter.next();
        }
        Integer i = peekedElement;
        hasPeeked = false;
        return i;
	}

	@Override
	public boolean hasNext() {
	    return hasPeeked || iter.hasNext();
	}
}

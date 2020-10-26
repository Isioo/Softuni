function getFibonator() {
    let current = 0;
    let next = 1;
  
    return () => {
      let nextNumber = current + next;
      current = next;
      next = nextNumber;
  
      return current;
    };
  }
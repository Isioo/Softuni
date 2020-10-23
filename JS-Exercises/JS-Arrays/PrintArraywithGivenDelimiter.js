function printAnArrayWithAGivenDelimiter(input) {
    let delimiter = input.pop();
    console.log(input.join(delimiter));
}
printAnArrayWithAGivenDelimiter ('One','Two','Three','Four','Five')
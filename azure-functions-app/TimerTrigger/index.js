function.exports = async function (context, myTimer) {
    const timeStamp = new Date().toISOString();
    context.log('Timer trigger function executed at: ', timeStamp);
    // Add your logic here
};
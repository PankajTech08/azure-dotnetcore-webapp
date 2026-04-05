module.exports = async function (context, eventHubMessages) {
    eventHubMessages.forEach((message) => {
        context.log(`Received message: ${message}`);
        // Add your event processing logic here
    });
    context.done();
};
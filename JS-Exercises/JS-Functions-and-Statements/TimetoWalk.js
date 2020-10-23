function solve(steps,stepLength, speed){
    let distanceInMeters = steps *stepLength;
    let speedForMetersInSec = speed / 3.6;
    let rest = Math.floor(distanceInMeters / 500);
    let time = distanceInMeters / speedForMetersInSec + rest * 60;

    let timeInHours = Math.floor(time/3600);
    let timeInMinutes = Math.floor(time/60);
    let timeInSeconds = Math.floor(time % 60);

   
    console.log((timeInHours < 10 ? "0" : "") + timeInHours + ":" + (timeInMinutes + rest < 10 ? "0" : "") + (timeInMinutes + rest) + ":" + (timeInSeconds < 10 ? "0" : "") + timeInSeconds);
   
}
solve(2564, 0.70, 5.5)
// *******************************************************
// W06 Eternal Quest Program
//
// Creativity and Exceeding Requirements:
//
// 1. Added congratulation messages when a checklist goal
//    is completed and the bonus is awarded.
//
// 2. Added validation so completed checklist goals cannot
//    earn additional points after reaching their target.
//
// 3. Added helper methods such as GetCount() and GetTarget()
//    to simplify loading saved checklist goals.
//
// 4. Improved the menu and score display to make the
//    program easier to use.
//
// These enhancements improve the user experience while
// demonstrating additional use of encapsulation and
// object-oriented design.
// *******************************************************

using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // - Added automatic save/load support.
        // - Checklist goals remember their progress.
        // - Program awards bonus points when checklist goals are completed.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
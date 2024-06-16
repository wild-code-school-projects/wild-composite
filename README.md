# wild-composite
Design Patterns - Composite

# Challenge

Your challenge is to implement a program representing a family tree starting from a single ancestor. It should be possible to reconstruct the entire family tree beginning with the first ancestor.

## Validation Criteria

- The application contains a `Person` class representing a family member.
- `Person` has a list of other `Person` instances as a property. This list contains direct descendants.
- Each `Person` has a `ToString()` method that returns its direct descendants in text format.
- By calling the `ToString()` method of a single `Person`, all descendants of that family member are returned in text format.

![image](https://image.noelshack.com/fichiers/2024/24/7/1718529993-screenshot-2024-06-16-112628.png)

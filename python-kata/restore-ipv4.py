import re 
from functools import total_ordering

"""
Restore IPv4Address class - https://www.codewars.com/kata/63a0f3f49547e9001e7ad1ca

IPv4Address class has been corrupted by a malevolent team lead. As a most experienced person in the team, you're tasked to restore the missing code. On the bright side, all the unit tests have been left intact. However, you have a gut feeling that you'll need to do something extraordinary…
"""

# TODO: Figure out how to make class not comparable to dynamically created class

@total_ordering
class IPv4Address: 
    def __init__(self, parts: list[int] | str):  # Type hint to ensure only specified types can be passed in
        """
        Creates an object representing an IPv4 address

        :param parts: a list of 4 integers
        """
        # Validate object using helper function
        # then return value to make it immutable
        self._parts = self._parts_validator(parts)
    
    # String method
    def __str__(self) -> str:
        return self._parts

    # Rich comparison methods
    def __eq__(self, other): 
        if not isinstance(other, IPv4Address):
            return False
        return self._parts == other._parts
    
    def __ne__(self, other) -> bool | object: # Not Equals
        pointer = 0

        if not isinstance(other, IPv4Address):
           return ValueError("Not an instance of an IPv4Address object")
        
        while pointer != len(self._parts):
            if self._parts[pointer] != other._parts[pointer]:
                return True
            else: 
                pointer += 1

        return False
              
    def __lt__(self, other) -> bool: # less than
        pointer = 0
        while pointer != len(self._parts):
            if self._parts < other._parts:
                pointer += 1
            else:
                return False
            
        return True
                
    def __hash__(self) -> int:
        return hash((self._parts,))

    # Property validation using @property decorator
    @property
    def parts(self):
        return self._parts
    
    # Helper function for input validation 
    def _parts_validator(self, ipv4) -> str:
        if  ipv4[0] == 0: # First part of address can't be 0
            raise ValueError('Should not create IPv4Address where first part is 0')
        
        if type(ipv4) == list:
            if len(ipv4) < 4: 
                raise ValueError('Should not create IPv4Address with less than 4 parts')
            if len(ipv4) > 4:
                raise ValueError('Should not create IPv4Address with more than 4 parts')
            if any(isinstance(i, str) for i in ipv4):
                raise ValueError('Should not create IPv4Address with non-integer parts')
            if any(num < 0 or num > 255 for num in ipv4):
                raise ValueError('address parts should be between 0 and 255')
            
            return  ".".join(list(map(str, ipv4)))

        elif type(ipv4) == str: # if a string is passed in, ensure it's a proper ipv4 address
            # TODO: Change regex to ensure that the first octet cannot be zero
            match = re.fullmatch("^(?:(?:25[0-5]|2[0-4]\\d|1?\\d{1,2})(?:\\.(?!$)|$)){4}$", ipv4) is not None
            if not match:
                raise ValueError('Invalid IPV4 address')
 
            return  ipv4
    
        raise TypeError("Parts must be list or string")

    @classmethod
    def from_string(cls, string):
         return cls(string)


print(IPv4Address([4,2,3,4]) != IPv4Address([2,2,3,4]))
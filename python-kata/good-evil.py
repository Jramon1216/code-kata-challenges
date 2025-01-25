def goodVsEvil(good, evil):

    good_worth = [1, 2, 3, 3, 4, 10]
    evil_worth = [1, 2, 2, 2, 3, 5, 10] # Set the worth for both sides
    
    good_counts = list(map(int, good.split()))
    evil_counts = list(map(int, evil.split())) # Turn strings into lists
    
    total_good_worth = sum(count * worth for count, worth in zip(good_counts, good_worth)) 
    total_evil_worth = sum(count * worth for count, worth in zip(evil_counts,  evil_worth)) # create tuples out of the worth and counts and mutliply them, then get the sum
    
    if total_good_worth > total_evil_worth: return "Battle Result: Good triumphs over Evil"
    elif total_good_worth < total_evil_worth: return "Battle Result: Evil eradicates all trace of Good" 
    else: return "Battle Result: No victor on this battle field"

goodVsEvil('0 0 0 0 0 10', '0 1 1 1 1 0 0')